namespace entityframeworkcore_one_to_one_relationship_example_project.Models
{
    public class CarCompany
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        // One-to-one relationship
        public CarModel? CarModel { get; set; } // Navigation property
    }
}
