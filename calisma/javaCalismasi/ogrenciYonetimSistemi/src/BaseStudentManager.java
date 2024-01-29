public class BaseStudentManager extends BaseStudentID {
        
    public Integer getStudentId() {
        return studentId;
    }
    public void setStudentId(Integer studentId) {
        this.studentId = studentId;
    }

    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }

    public String getDepartment() {
        return department;
    }
    public void setDepartment(String department) {
        this.department = department;
    }

    public Integer getStudentClass() {
        return studentClass;
    }
    public void setStudentClass(Integer studentClass) {
        this.studentClass = studentClass;
    }

    public String[] getSemesterCourses() {
        return semesterCourses;
    }
    public void setSemesterCourses(String[] semesterCourses) {
        this.semesterCourses = (String [])semesterCourses;
    }


    
}
