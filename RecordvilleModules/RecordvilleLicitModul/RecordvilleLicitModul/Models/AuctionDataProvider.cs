using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LicitModul.DnnRecordvilleLicitModul.Models
{
    public class AuctionDataProvider
    {
        private readonly string connectionString = "YourConnectionStringHere";

        // Aktív aukciók lekérése
        /*public List<Auction> GetActiveAuctions()
        {
            using (var context = new SqlConnection(connectionString))
            {
                context.Open();
                string query = "SELECT * FROM Auctions WHERE EndTime > GETDATE()";
                SqlCommand cmd = new SqlCommand(query, context);
                SqlDataReader reader = cmd.ExecuteReader();

                List<Auction> auctions = new List<Auction>();
                while (reader.Read())
                {
                    auctions.Add(new Auction
                    {
                        Id = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        StartingPrice = reader.GetDecimal(2),
                        CurrentBid = reader.GetDecimal(3),
                        MinimumBidIncrement = reader.GetDecimal(4),
                        StartTime = reader.GetDateTime(5),
                        EndTime = reader.GetDateTime(6)
                    });
                }
                return auctions;
            }
        }*/

        public List<Auction> GetActiveAuctions()
        {
            return new List<Auction>
    {
        new Auction { Id = 1, ProductName = "The Beatles - Yesterday and Today", CurrentBid = 25.00M, MinimumBidIncrement = 1.00M, StartTime = DateTime.Now.AddDays(-1), EndTime = DateTime.Now.AddDays(5) },
        new Auction { Id = 2, ProductName = "Vintage Vinyl Record", CurrentBid = 50.00M, MinimumBidIncrement = 2.00M, StartTime = DateTime.Now.AddDays(-2), EndTime = DateTime.Now.AddDays(7) }
    };
        }



        // Aukció létrehozása
        public void CreateAuction(Auction auction)
        {
            using (var context = new SqlConnection(connectionString))
            {
                context.Open();
                string query = "INSERT INTO Auctions (ProductName, StartingPrice, CurrentBid, MinimumBidIncrement, StartTime, EndTime) " +
                               "VALUES (@ProductName, @StartingPrice, @CurrentBid, @MinimumBidIncrement, @StartTime, @EndTime)";
                SqlCommand cmd = new SqlCommand(query, context);
                cmd.Parameters.AddWithValue("@ProductName", auction.ProductName);
                cmd.Parameters.AddWithValue("@StartingPrice", auction.StartingPrice);
                cmd.Parameters.AddWithValue("@CurrentBid", auction.CurrentBid);
                cmd.Parameters.AddWithValue("@MinimumBidIncrement", auction.MinimumBidIncrement);
                cmd.Parameters.AddWithValue("@StartTime", auction.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", auction.EndTime);
                cmd.ExecuteNonQuery();
            }
        }

        // Licit hozzáadása
        public void PlaceBid(int auctionId, decimal bidAmount)
        {
            using (var context = new SqlConnection(connectionString))
            {
                context.Open();
                string query = "UPDATE Auctions SET CurrentBid = @BidAmount WHERE Id = @AuctionId";
                SqlCommand cmd = new SqlCommand(query, context);
                cmd.Parameters.AddWithValue("@BidAmount", bidAmount);
                cmd.Parameters.AddWithValue("@AuctionId", auctionId);
                cmd.ExecuteNonQuery();
            }
        }
    }

}