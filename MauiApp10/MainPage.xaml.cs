using System.Collections.ObjectModel;
using SQLite;

namespace MauiApp10
{
    [Table("Mushroom")]
    public class Mushroom
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string NameMushroom { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Mushroom> Mushrooms { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Mushrooms = new ObservableCollection<Mushroom>
            {
                new Mushroom { NameMushroom = "Белый гриб", Description = "болетус съедобный, боровик", Image = "bg.jpg"},
                new Mushroom { NameMushroom = "Бледная поганка", Description = "смертельно ядовитый гриб", Image = "bp.jpg" },
                new Mushroom { NameMushroom = "Сморчок", Description = " род шляпочных грибов из отдела аскомицеты", Image = "smar.jpg" },
                new Mushroom { NameMushroom = "Подосиновик", Description = "съедобный гриб из рода лекцинум", Image = "pod.jpg"},
                new Mushroom { NameMushroom = "Шиитаке", Description = "вид рода Лентинула семейства Негниючниковые", Image = "shee.jpg" },
                new Mushroom { NameMushroom = "Лисичка", Description = "лисичка обыкновенная", Image = "li.jpg" },
                new Mushroom { NameMushroom = "Сыроежка", Description = "род пластинчатых грибов", Image = "sir.jpg" }
            };

            BindingContext = this;
        }

    }

}
