//bir class bieden fazla interface i implement e edebilirken bir class birden fazla abstruct i extent edemez
public class MySqlCustomerDal implements ICustomerDal, IRepository{

    @Override
    public void add() {
        System.out.println("My sql eklendi");        
    }
    
}
