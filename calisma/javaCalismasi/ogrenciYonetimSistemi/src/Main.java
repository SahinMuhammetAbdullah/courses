public class Main {
    public static void main(String[] args) throws Exception {

        BaseStudentManager student1 = new BaseStudentManager();
        ComputerEngineerLessones studentLessones = new ComputerEngineerLessones();

        student1.setStudentId(21060622);
        student1.setName("Muhammet Abdullah Sahin");
        student1.setStudentClass(1);
        
        student1.setSemesterCourses((String[] )studentLessones.classOneFirst());

        for (String string : student1.getSemesterCourses()) {
            System.out.println(string);
        }


    }
}
