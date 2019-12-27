using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment.Code
{
    public class ColorCordinator
    {       
        public string shirtColor { get; set; }

        public IList<string> ListShoes  { get; set; }
      
        public ColorCordinator()
        {
           
        }
                
        public void RunColorCordinatorForPants(String pantsColor)
        {
            this.shirtColor = GetShirtColor(pantsColor);
            this.ListShoes = GetShoeColor(pantsColor);            
        }

        private string GetShirtColor(String pantsColor)
        {
            if (pantsColor == "" || pantsColor == "white")
            {
                return "error";                
            }

            switch (pantsColor)
            {
                case "red":
                    return "pink";                    

                case "blue":
                    return "green";
      
                case "green":
                    return "blue";
        
                case "pink":
                    return "yellow";
                   
                case "black":
                    return "white";                  

                default:
                    return "black";                  
            }
        }   

        private IList<string> GetShoeColor(String pantsColor)
        {
            IList<string> objShoeList = new List<string>();

            switch (pantsColor)
            {
                case "red":
                    objShoeList.Add("brown");
                    objShoeList.Add("black");
                    break;

                case "blue":
                    objShoeList.Add("white");
                    objShoeList.Add("black");
                    break;

                default:
                    objShoeList.Add("black");
                    break;
            }
                       
            return objShoeList;
        }

    }
}