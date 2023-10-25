namespace RederijClassLibrary
{
    internal class Rederij
    {
        public List<Vloot> Vloten { get; set; } = new List<Vloot>();
        public List<string> Havens { get; set; } = new List<string>();
        public List<Schip> Schip { get; set; } = new List<Schip>();

        public void VoegVlootToe(Vloot v)
        {
            Vloten.Add(v);
        }
        public void VerwijderVloot(Vloot v)
        {
            Vloten.Remove(v);
        }
        public Vloot ZoekNaarVloot(string naam)
        {
            Vloot v = new Vloot();
            return v;
        }
        public double GeefCargoWaarde()
        {
            double waarde = 0;
            return waarde;
        }
        public int GeefPassagiers()
        {
            int passagiers = 0;
            return passagiers;
        }
    }
}
