class Main{
	public static void main(String[] args){
		Kutu k1 = new Kutu();
		Kutu k2 = new Kutu();

		k1.x=2; k1.y=3; k1.z=3; k1.kirilir=true; k1.yuzey_kodu=0;
		k2.x=2; k2.y=5; k2.z=3; k2.kirilir=false; k2.yuzey_kodu=5;

		System.out.println("kutu 1 hacim = " + (k1.x*k1.y*k1.z));
		System.out.println("kutu 2 hacim = " + (k2.x*k2.y*k2.z));

	}
}