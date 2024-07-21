using FirstWebAppPB301.Models;

namespace FirstWebAppPB301.ViewModels
{
    public class HomeVM
    {
        public string GroupName { get; set; }
        public Student Student { get; set; }
        public List<Student> Students { get; set; }
    }
}
