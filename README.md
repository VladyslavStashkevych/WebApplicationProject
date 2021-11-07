# Web-Application Project
Training project with ASP.NET core MVC, EF core and MS SQL.
<pre>
<h2>Version 1.0</h2>
<h4>My Borrowed Items</h4>
This is a list of "Item Name", "Borrower" and "Lender" columns. 
You can add new items to that table with "Create new Item" button.
<h4>My Expenses</h4>
This is a list with same functionality as previous, but it also has "Update" and "Delete" buttons, 
which allow user to update or delete information from table. Items also have validation for invalid input, 
such as empty field, invalid value type and negative number for "Cost" field. Also Cost is formated as "$0.00".
</pre>

<pre>
<h2>Version 1.1</h2>
<h4>Bug fixes</h4>
-Default route was changed from "/Home/Index" to "/Item/Index".
-"Delete" button is now redirecting to "/Delete". Earlier it was"/DeletePost".
<h4>Cosmetic changes</h4>
-Now every page has its own title "Action - List".
-Blue "Update" button is now green "Edit". 
-"My Borrowed Items" is now "Borrowed Items", "My expenses List" - "My Expenses List", "Purchase Name" was changed to "Expense", "Cost" to "Amount". 
-Blue "Create new Item" button is now dark-outlined "Add new Item" button. 
 it also fills with grey color, when mouse is on this button.  
-"Edit" and "Delete" button have now equal size, normal space in-beetween and rounded shape. 
</pre>
