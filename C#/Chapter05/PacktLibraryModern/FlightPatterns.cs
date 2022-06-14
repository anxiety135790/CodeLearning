///////////////////////////////////
// namespace PacktLibraryModern; //
// public class Class1           //
// {                             //
//                               //
// }                             //
///////////////////////////////////

namespace Packt.Shared
{
    public class BusinessClassPassenger
    {
        public override string ToString()
        {
            return $"BusinessClass";
        }
    }

    public class FirstClassPassenger
    {
        public override string ToString()
        {
            return $"Business Class";
        }
    }

    public class  FirstClassPassenger
    {
        public int AirMiles{get; set;}

        public override string Tostring()
        {
            return $"First Class with {AirMiles.M0} air miles";
        }

    }

    public class CoachClassPassenger
    {
        public double CarryOnKG{get; set;}

        public override string ToString(){
            return $"Coach Class with {CarryOnKG:M2} KG carry on";
        }
    }




}

               
