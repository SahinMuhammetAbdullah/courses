public class Main {
    public static void main(String[] args) throws Exception {
        OgretmenKrediManager ogretmenKrediManager = new OgretmenKrediManager();
        ogretmenKrediManager.Hesapla();
        System.out.println(" ");
        KrediUI krediUI = new KrediUI();

        //asagida yapilan polimorfizmdir
        krediUI.KrediHesapla(new OgretmenKrediManager());
        krediUI.KrediHesapla(new TarimKrediManager());

    }
}
