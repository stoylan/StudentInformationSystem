# Student Information System

<img src = "/ProjectScreenshots/mysqlWorkBench.jpg" height="60%" width="60%">

We used mysql as the database and we used mysql workbench to use the localhost server and keep the tables. To run the database, the localhost's username must be root and the password must be 12345. Also, to add the database to mysql workbench, we need to create a schema named studentinfo in the schemas option after logging in localhost. Then we need to go to the data import / restore section from the administration section and select the import from dump project folder option and select the database folder. After clicking start import, our database has been imported.

## Samet Toylan

I worked our project’s login and register student parts so that I create forms,classes and design  StartScreenForm,StudentLoginForm,StudentRegisterForm. Also Database, verifyLogin, RegisterStudent, RegisterLesson classes, getStudentid() method in student class and updateAndGetAVG() method in lesson class. This pages also has one advanced controller that is showing the date and time.

<img src = "/ProjectScreenshots/startScreen.jpg" height="60%" width="60%">

In this page user must select to login as a student or a teacher

---

<img src = "/ProjectScreenshots/studentLogin.jpg" height="60%" width="60%">

In studentlogin form, If the student is registered in the system, he/she can login. If not, they can go to the register form by clicking the register button in the middle of the form. After clicking login button, database check if the correct username and password and sent student id of the logged in student to studentscreen.  

---

<img src = "/ProjectScreenshots/studentRegister.jpg" height="60%" width="60%">

On the student registration screen, student number and phone number textbox only accepts numbers. Also, if the format entered in the e-mail textbox is not in e-mail format, it gives a warning. It is checked through the database whether the entered username has been received by another user before. The password entered is required to be at least 6 characters long. In addition, students must choose at least one course. The enrolled student and the courses taken by the student are kept with the same ID in the database.

---

## Mehmet Furkan Çevik

I worked our project’s Teacherside so that I create forms,classes and design  Attendanceform,TeacherLoginform,TeacherScreenform, Teacher class and lesson class.

<img src = "/ProjectScreenshots/attendance.jpg" height="50%" width="50%">

Attendance.cs
This form for setting lesson’s attedancelimits so that teacher’s can change to lesson’s limit.

---

<img src = "/ProjectScreenshots/teacherLogin.jpg" height="60%" width="60%">

This form for verifying teacher’s login and sent username’s id  to anotherform (TeacherScreen) so that in TeacherScreen.cs can set controltabpages Teacher’s lessons 
dynamically from getting database.This page also has one advanced controller that is showing the date and time.

---

<img src = "/ProjectScreenshots/teacherScreen.jpg" height="60%" width="60%">

TeacherScreen.cs
This form default has  three tabpage in tabcontrol for the teacher’s lessons size page’s remove (because everyteacher has most three lessons) .After created the tabpagenames and lessons’ data setting datagridview from database dynamically,also teacher can change and update the stundents’ midterm,final and attendances.This page also has two advanced controller, one of these is showing the date and time,another one is sliding teachername’s.
Lesson.cs
This class for lessons database operations this class has six methods but I wrote four methods fillgrade,getabsentlimit, updateGrade ve updateWordGrade.Fillgrade for taking and writing grades teacherscreen’s datagridviews,getAbsentLimit for Absentscreen, updateGrade ve updateWordGrade update and setting grades info.

Teacher.cs
This class that is describing the teacher.Properties are username,password,name,surname,lessons.This class has three methods those are:getTeacherName,getTeacherid and getTeacherLesson.First method for getting teacher name from the database,second is getting teacher id from database and last one getting lesson from database.
Actually, we tried to keep solid princeples as much as possible

---

## Tolga Demirci

 My part is Student in Student Information System  that  we worked.  
Update Information.cs = Students have to enter the same password in 2 different texts in order 
to update their information.. If a student  enters the  password. If the student enters two different 
passwords in the texts, the information is not updated.Also, The parts which are recorded is only 
their g-mail and telephone number. The student never  change  ‘’Name and Surname ‘’.

<img src = "/ProjectScreenshots/updateInformation.jpg" height="50%" width="50%">

---

StudentScrenn.cs= i created ListGrade,Transcript , Update Information texts and also Data 
Griedview.  I used Deletestudent() and Get Student() methods in Student Class. Also, i used 
BringGrade() method in Lesson Class. I added the scrolling text with timer. When each different 
student logs in, the name of whoever logged in appears in the text. Transtion is made from 
the StudentScreen to Update Information when you click Update Information text in Student Screen 
form. I created Date and Time.

<img src = "/ProjectScreenshots/studentScreen.jpg" height="60%" width="60%">

Transcript.Cs= In this part, i created a text file and students can view their grades.I pulled the 
grade,word grade and overall average thanks to this method( Public string getTranscriptRecord(int 
studentid,String studentname) )

<img src = "/ProjectScreenshots/transcript.jpg" height="60%" width="60%">







