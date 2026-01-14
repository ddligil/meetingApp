using meetingApp.Models;

namespace meetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new(); //UserInfo classının nesnelerini tutan boş bir liste oluştur ve adına _users de
static Repository()
{
    _users.Add(new UserInfo()
    {
        Id=1,
        Name="Dila",
        Email="dila@example.com",
        Phone="1234567890",
        WillAttend=true
    });
}


        public static List<UserInfo> Users //Listeyi okumak için
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user) //Yeni kullanıcıyı listeye ekler.Formdan gelen veri burada saklanır
        {   user.Id=Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetUserById(int id) //Id ye göre kullanıcıyı getirir
        {
            return _users.FirstOrDefault(i => i.Id == id); //metot Şarta uyan İLK elemanı getirir yoksa null döndür
        }


    }
}
