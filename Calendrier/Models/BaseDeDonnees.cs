using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Calendrier.Models
{
    public class BaseDeDonnees

    {
        
        public List<Jour> Jours { get; set; }
        public List<Fond> fonds { get; set; }
        public Photo photo { get; set; }

        
        public BaseDeDonnees()
        {
            Jours = new List<Jour>();
            Jours.Add(new Jour() { Id = 1,  Page_couverture = "1.png",  day = DateTime.Parse("2021-12-01"), Musique = "1.mp3", ouvert = false, Photo = null  });
            Jours.Add(new Jour() { Id = 2,  Page_couverture = "2.png",  day = DateTime.Parse("2021-12-02"), Musique = "2.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 3,  Page_couverture = "3.png",  day = DateTime.Parse("2021-12-03"), Musique = "3.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 4,  Page_couverture = "4.png",  day = DateTime.Parse("2021-12-04"), Musique = "4.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 5,  Page_couverture = "5.png",  day = DateTime.Parse("2021-12-05"), Musique = "5.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 6,  Page_couverture = "6.png",  day = DateTime.Parse("2021-12-06"), Musique = "6.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 7,  Page_couverture = "7.png",  day = DateTime.Parse("2021-12-07"), Musique = "7.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 8,  Page_couverture = "8.png",  day = DateTime.Parse("2021-12-08"), Musique = "8.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 9,  Page_couverture = "9.png",  day = DateTime.Parse("2021-12-09"), Musique = "9.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 10, Page_couverture = "10.png", day = DateTime.Parse("2021-12-10"), Musique = "10.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 11, Page_couverture = "11.png", day = DateTime.Parse("2021-12-11"), Musique = "11.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 12, Page_couverture = "12.png", day = DateTime.Parse("2021-12-12"), Musique = "12.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 13, Page_couverture = "13.png", day = DateTime.Parse("2021-12-13"), Musique = "13.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 14, Page_couverture = "14.png", day = DateTime.Parse("2021-12-14"), Musique = "14.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 15, Page_couverture = "15.png", day = DateTime.Parse("2021-12-15"), Musique = "15.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 16, Page_couverture = "16.png", day = DateTime.Parse("2021-12-16"), Musique = "16.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 17, Page_couverture = "17.png", day = DateTime.Parse("2021-12-17"), Musique = "17.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 18, Page_couverture = "18.png", day = DateTime.Parse("2021-12-18"), Musique = "18.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 19, Page_couverture = "19.png", day = DateTime.Parse("2021-12-19"), Musique = "19.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 20, Page_couverture = "20.png", day = DateTime.Parse("2021-12-20"), Musique = "20.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 21, Page_couverture = "21.png", day = DateTime.Parse("2021-12-21"), Musique = "21.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 22, Page_couverture = "22.png", day = DateTime.Parse("2021-12-22"), Musique = "22.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 23, Page_couverture = "23.png", day = DateTime.Parse("2021-12-23"), Musique = "23.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 24, Page_couverture = "24.png", day = DateTime.Parse("2021-12-24"), Musique = "24.mp3", ouvert = false, Photo = null });
            Jours.Add(new Jour() { Id = 25, Page_couverture = "25.png", day = DateTime.Parse("2021-12-25"), Musique = "25.mp3", ouvert = false, Photo = null });

            fonds = new List<Fond>();
            fonds.Add(new Fond() { Fonds = "1.jpg" });
            fonds.Add(new Fond() { Fonds = "2.jpg" });
            fonds.Add(new Fond() { Fonds = "3.jpg" });
            fonds.Add(new Fond() { Fonds = "4.jpg" });
            fonds.Add(new Fond() { Fonds = "5.jpg" });
            fonds.Add(new Fond() { Fonds = "6.jpg" });
            fonds.Add(new Fond() { Fonds = "7.jpg" });

            foreach (var item in Jours)
            {
                Photo photo = new Photo();
                photo.Id = item.Id;
                if (File.Exists(Directory.GetCurrentDirectory() +"/wwwroot/_xx/"+ item.Id+".jpg"))
                {
                    photo.photo = item.Id + ".jpg";
                    item.Photo = photo;
                }
                else
                {
                    item.Photo = null;
                }
            }
        }


        public void save(Photo photo)
        {
            Jours.Where(x => x.Id == photo.Id).SingleOrDefault().Photo = photo;
        }
    }
}
