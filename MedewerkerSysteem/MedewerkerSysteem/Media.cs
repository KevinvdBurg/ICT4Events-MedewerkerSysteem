namespace MedewerkerSysteem
{
    public class Media
    {
        public int PostID { get; set; }
        public int AANTALREPORTS { get; set; }
        public string Inhoud { get; set; }
        public string Bestandlocatie { get; set; }

        public Media(int postId, int aantalreports, string inhoud, string bestandlocatie)
        {
            PostID = postId;
            AANTALREPORTS = aantalreports;
            Inhoud = inhoud;
            Bestandlocatie = bestandlocatie;    
        }
    }
}