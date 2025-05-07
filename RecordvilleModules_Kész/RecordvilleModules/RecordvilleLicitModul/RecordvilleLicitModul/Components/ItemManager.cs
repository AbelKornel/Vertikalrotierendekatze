/*
' Copyright (c) 2025 Vertikalrotierendekatze
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using DotNetNuke.Data;
using DotNetNuke.Framework;
using LicitModul.DnnRecordvilleLicitModul.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LicitModul.DnnRecordvilleLicitModul.Components
{

    internal interface IItemManager
    {
        void CreateItem(Item t);
        void DeleteItem(int itemId, int moduleId);
        void DeleteItem(Item t);
        IEnumerable<Item> GetItems(int moduleId);
        Item GetItem(int itemId, int moduleId);
        void UpdateItem(Item t);
    }

    public class AuctionGenerator
    {
        private static readonly AuctionGenerator _instance = new AuctionGenerator();

        public static AuctionGenerator Instance => _instance;

        private AuctionGenerator() { }

        public void CreateBid(Auction bid)
        {
            using (var context = DataContext.Instance())
            {
                var repository = context.GetRepository<Auction>();
                repository.Insert(bid);
            }
        }

        public IEnumerable<Auction> GetBidsByItemId(int itemId)
        {
            using (var context = DataContext.Instance())
            {
                var repository = context.GetRepository<Auction>();
                return repository.Get(itemId);
            }
        }
    }

    internal class AuctionManager
    {
        private static readonly AuctionManager _instance = new AuctionManager();
        public static AuctionManager Instance => _instance;

        private AuctionManager() { }

        public IEnumerable<Item> GetItems(int moduleId)
        {
            System.IO.File.AppendAllText(@"C:\temp\checkpoint.txt",
                $"[GetItems] ModuleId={moduleId}, idő: {DateTime.Now}\n");

            using (var ctx = DotNetNuke.Data.DataContext.Instance())
            {
                var result = ctx.ExecuteQuery<Item>(
                    System.Data.CommandType.Text,
                    "SELECT * FROM RecordvilleLicitModul_Items WHERE ModuleId = @0",
                    moduleId).ToList();

                System.IO.File.AppendAllText(@"C:\temp\checkpoint.txt",
                    $"  → Visszatérő lista hossza: {result.Count}\n");

                return result;
            }
        }

        public Item GetItem(int itemId, int moduleId)
        {
            System.IO.File.WriteAllText(@"C:\temp\getitem-check.txt", $"GetItem called for item {itemId}, module {moduleId}");

            using (var ctx = DataContext.Instance())
            {
                var sql = "SELECT * FROM RecordvilleLicitModul_Items WHERE ItemId = @0 AND ModuleId = @1";
                return ctx.ExecuteQuery<Item>(
                    System.Data.CommandType.Text,
                    sql, itemId, moduleId).FirstOrDefault();
            }
        }

        public void CreateItem(Item t)
        {
            using (var ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Item>();
                rep.Insert(t);
            }
        }

        public void UpdateItem(Item t)
        {
            using (var ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Item>();
                rep.Update(t);
            }
        }

        public void DeleteItem(Item t)
        {
            using (var ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Item>();
                rep.Delete(t);
            }
        }

        public void DeleteItem(int itemId, int moduleId)
        {
            var t = GetItem(itemId, moduleId);
            DeleteItem(t);
        }

    }

}