using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Assignment2.Data;


namespace Models {
public class Family {
    
    //public int Id { get; set; }
    [Required]
    public string StreetName { get; set; }
    [Required]
    public int HouseNumber{ get; set; }
    public AdultList Adults { get; set; }
    public ChildList Children{ get; set; }
    public List<Pet> Pets{ get; set; }

    public Family() {
        Adults = new AdultList();
        Children = new ChildList();
        Pets = new List<Pet>();
    }

    public Family Copy()
    {
        Family copy = new Family
        {
            StreetName = StreetName,
            HouseNumber = HouseNumber,
            Adults = Adults.GetAllWithAdultList(),
            Children = Children.GetAllWithChildList(),
            Pets = new List<Pet>(Pets)
        };
        return copy;
    }
}


}