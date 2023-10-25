namespace RederijClassLibrary
{
    internal class Vloot
    {
        public string Naam { get; set; }
        public List<Schip> Schepen { get; set; }

        public void VoegSchipToe(Schip schip)
        {
            Schepen.Add(schip);
        }

        public void VerwijderSchip(Schip schip)
        {
            Schepen.Remove(schip);
        }
        public Schip ZoekSchip(Schip schip)
        {
            return schip;
        }
    }
}
