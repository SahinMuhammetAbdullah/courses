public class Main {
    public static void main(String[] args) throws Exception {
        Product product = new Product();
        
        product.setName("Laptop");
        product.setId(16854132);
        product.setDescription("Asus Laptop");
        product.setPrices(4999.99);
        product.setStockAmount(3);


        System.out.println(product.getKod());

        Product product2 = new Product(1, "Pc", "Asus", 99999.99, 3, "mavi");
        
        System.out.println(product2.getName());
        
        ProductManager productManager = new ProductManager();
        productManager.Add(product);

        /*productManager.Add2(1, "", "", 2, 200);
        productManager.Add2(1, "", "", 2, 200);
        productManager.Add2(1, "", "", 2, 200);
        productManager.Add2(1, "", "", 2, 200);
        productManager.Add2(1, "", "", 2, 200);
        productManager.Add2(1, "", "", 2, 200);*/ //hatali kullanim 9202
        
    }
}
