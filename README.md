# AggregationEx1

Student
In this stateful class, employee information is held in auto-properties. The ToString method returns the
combined concatenation of the four properties.

CollegeProgram
The program name must be no more than 20 characters long and cannot be blank. The AddStudent
method allows for a new student to be added to the list, and the overloaded Retrieve methods allow for
the retrieval of students from the list. Throw an exception if the student does not exist in the list.

Validate
This class is a Static class. Error messages should be created in the caller as this class returns only a
Boolean.

Write unit tests for the CollegeProgram class members.

Once all unit tests pass, create a forms app to:

 When the form loads, a CollegeProgram is created. Add 3 or 4 students to the CollegeProgram.
Make at least 2 of them have the same name
 Provide a box for the user to enter a student id. When button is clicked, you will retrieve the
student that matches the id entered, and message box the details of that student (using the
tostring method you created)
 Provide another box where the user can enter a name. When a button is clicked, you will get all
the students with that name and output their details.
