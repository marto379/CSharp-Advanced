namespace Zoo
{
    public class Animal
    {
        string species;
        string diet;
        double weight;
        double lenght;

        public string Species { get => species; set => species = value; }
        public string Diet { get => diet; set => diet = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Lenght { get => lenght; set => lenght = value; }

        public Animal(string species, string diet, double weight, double lenght)
        {
            Species = species;
            Diet = diet;
            Weight = weight;
            Lenght = lenght;

        }

        public override string ToString()
        {
            return $"The {this.Species} is a {this.Diet} and weighs {this.Weight} kg.";
        }
    }
}
