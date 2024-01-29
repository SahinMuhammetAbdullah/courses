public class Product {
    // constructor(olusturucu) yapisi yani Product product = new 'Product()'; yapisinda new den sonraki tirnak icinde bulunan yapidir. bu hamle yapilmazsa defult olarak vardir lakin bu yapildigi zaman eger parametre alan bir olusturucu yazarsak ve bu parametre almayan yapiyi olusturmazsak defult olusturucuyu kullanamayiz
    public Product() {
        System.out.println("yapici blok calisti");

    }

    //yu yapiyi kullanabilmek icin this. yapisis kullanilmali
    public Product(int id, String name, String descraption, double prices, int stockAmount, String renk) {
        this.id = id;
        this.name = name;
        this.description = descraption;
        this.prices = prices;
        this.stockAmount = stockAmount;
        this.renk = renk;
        this.kod = this.name.substring(0,1) + id;
    }

    // bu iki yapi ayni anda kullanildigi zaman overloding(asiri yukleme) olur 

    // attribute || field
    private int id;
    private String name;
    private String description;
    private double prices;
    private int stockAmount;
    private String renk;
    private String kod;


    /*
    // read only // getter
    public int getId() {
        //
        return _id;
    }

    public void setId(int id) {
        _id = id;
        // this.id = id; // this.id yapisi icinde bulundugum class demek
    } 
    */

    // otomatik yapmak icin sag tik ve source actiona bas
    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public String getDescription() {
        return description;
    }
    public void setDescription(String description) {
        this.description = description;
    }
    public double getPrices() {
        return prices;
    }
    public void setPrices(double prices) {
        this.prices = prices;
    }
    public int getStockAmount() {
        return stockAmount;
    }
    public void setStockAmount(int stockAmount) {
        this.stockAmount = stockAmount;
    }
    public String getRenk() {
        return renk;
    }
    public void setRenk(String renk) {
        this.renk = renk;
    }
    public String getKod() {
        this.kod = this.name.substring(0,1) + id;
        return kod;
    }

    
}