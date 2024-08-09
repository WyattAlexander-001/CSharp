using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.Models {
    /// <summary>
    /// Represents an address.
    /// </summary>
    public class Address {
        [Key] 
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
