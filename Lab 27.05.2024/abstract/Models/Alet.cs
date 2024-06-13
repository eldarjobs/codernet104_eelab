using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Abstract.models;


public enum Hammadde
{
    Agac,
    Metal,
    Plastik
}



public interface IAlet { }
public abstract class Alet : IAlet
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Aciklama { get; set; }
    public decimal Fiyat { get; set; }
    public string UretimYeri { get; set; }
    public Hammadde Hammadde { get; set; }

    public abstract string Sound();
}
public class Bateri : Alet
{
    public string DeriTipi { get; set; }

    public override string Sound() => "Tak Tak Tak";    
    
}
public class Keman : Alet
{
    public string Teltipi { get; set; }
    public string Arse { get; set; }

    public override string Sound() => "Cik Cik Cik";
   
}
public class Gitar : Alet
{
    public bool AkustikMi { get; set; }

    public override string Sound() => "Cik Cik Cik";    
   
}
public class Piano : Alet
{
    public string Teltipi { get; set; }
    public string TusTakimi { get; set; }

    public override string Sound() => "Ding ding ding";
    
}