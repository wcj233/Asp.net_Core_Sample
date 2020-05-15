using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class InfoDataService
    {
        public List<Pet> Pets{ get; set; }
        = new List<Pet>
        {
            new Data.Pet(){PetId="1",LastName="haha",FirstName="heihei",Date=new DateTime(2020, 1, 1),Phone="187"}
        };

        public Pet EditPet { get; set; }
    }
}
