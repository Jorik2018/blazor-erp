namespace blazor_erp.Data {
    
    public class PizzaEntity {

        public int Id { get; set; }
        
        public string? Name { get; set; }
        
        public string? Description { get; set; }
        
        public decimal Price { get; set; }
        
        public bool Vegetarian { get; set; }
        
        public bool Vegan { get; set; }

    }

}
