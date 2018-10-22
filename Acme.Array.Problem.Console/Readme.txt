Hello,

GitHub Link
https://github.com/JimRieck/Acme.Array.Program.git

1.	Draw a diagram to show the code flow.
	See the program flow.pdf file

2.	Explain what tests you would write and why.
	Tests TestValidNumberList() – Happy path for when there is a list of numbers and only 1 missing.
    TestNULLNumberList() – Negative edge case that passes in a null list of numbers and tests that the ArgumentNullException is called.
    TestNoItemsInListNumberList() – Negative edge case that passes in a valid list of numbers object but the list has no elements in it.  The tests expects the InvalidDataException exception is thrown.
    TestMoreThan1MissingNumberNumberList() – Negative edge case that passes in a list of numbers from 1-10 with 2 numbers missing.  The ArgumentOutOfRangeException is tested.

3.	Write the function. Use any language you want.
	See the solution at https://github.com/JimRieck/Acme.Array.Program.git

4.	Explain why you wrote the code the way you did.
	So a couple of things here.
		1.  I used an interface so the objects are loosly coupled and for future extensibility.
		2.  I used an abstract base class that inherits from the interface.  The reason is because of the SOLID principles of designing software which says a class should be open to extension and closed to modification.

5.	Is your code ready for production? Why or Why Not?
	The code is ready to move towards production because it has a variety of unit tests both happy path and negative edge cases.  It also is deisnged with the SOLID principles in mind.  However, I would not deploy it to production without a QA automation test and a peer and architect code review.  Both things would ensure a higher quality deployment.
