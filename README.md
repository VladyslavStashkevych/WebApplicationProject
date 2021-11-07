# WebApplicationProject
Training project with ASP.NET core MVC, EF core and MS SQL.

<h2>Version 1.0</h2>

<h4>My Borrowed Items</h4>
This is a list of "Item Name", "Borrower" and "Lender" columns. You can add new items to that table with "Create new Item" button.
<h2></h2>
<h4>My Expenses</h4>

This is a list with same functionality as previous, but it also has "Update" and "Delete" buttons, which allow user to update or delete information from table. Items also have validation for invalid input, such as empty field, invalid value type and negative number for "Cost" field. Also Cost is formated as "$0.00".

<h2>Version 1.1</h2>
<h4>Bug fixes</h4>
<p>-Default route was changed from "/Home/Index/" to "Item/Index".
<p>-"Delete" button is now redirecting to "/Delete". Earlier it was"/DeletePost".
<h2></h2>
<h4>Cosmetic changes</h4>

<p>-Now every page has its own title "Action - List".
<p>-Blue "Update" button is now green "Edit".
<p>-"Purchase Name" was changed to "Expense", "Cost" to "Amount".
<p>-Blue "Create new Item" button is now dark-outlined "Add new Item" button. And it fills with grey color, when mouse is on this button.
<p>-"Edit" and "Delete" button have now equal size, normal space in-beetween and rounded shape.
