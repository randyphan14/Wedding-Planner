using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Guest
    {
        [Key]
        public int GuestId {get;set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int WeddingId {get;set;}
        public Wedding Wedding {get;set;}
    }

    public class AssociationProduct
    {
        public int ProductId {get;set;}
    }

    public class AssociationCategory
    {
        public int CategoryId {get;set;}
    }
}