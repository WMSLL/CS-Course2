using System;

namespace ClassWork11
{
    public class  Pets
    {
        public string Kind { get; set; }        
        public string Name { get; set; }
        public char Sex { get; set; }        
        public DateTimeOffset DateOfbirth { get; set; }
        
        
       

       

        public void UpdatePropert(string name, string kind)
        {
            if(name==null || kind==null )
            {
                throw new ArgumentException();
            }
            Name = name;
            Kind = kind;
        }

        public void UpdatePropert(string name, string kind,char sex,DateTimeOffset date)
        {

          
                if (name == null || kind == null)
            {
                throw new ArgumentException();
            }
           
                
            
            
            Name = name;
            Kind = kind;
            Sex = sex;
            DateOfbirth = date;
            
        }



       
    }
}
