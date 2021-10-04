# Reviews Site
Opinions. You know the saying...everyone has one. And the Internet has made them easier to consume, or ignore. Acquisitions, Inc. has many, many products from its years of, well, acquiring things. They have asked you to build a reviews site for some of their current products. The data gathered will help them gain insight into their customer base and the products they have come to enjoy...or enjoy less.

Acquisitions, Inc. requires:
- Development of a MVC Web Application by a team that practices agile methodology, utilizes test driven design, and values clean code
- Appropriate use of Git and access to your application on GitHub
- Useful instructions in the form of a README.md file
- Ability for Users to:
   - view reviews on products
   - create, read, update, and delete their own reviews

## Sprint 1 Deliverable: Product Index and Detail Views

### User Stories
**Product Index View**
- As a user, I would like to see a list of Products, so that I have an index of all the Products that exist.
**Product Details View**
- As a user, I would like to see the details for a chosen Product, so that I can understand more about the Product.

### Details

- Create an MVC Web Application with appropriate xUnit tests.
- Before you add any code, create a dev branch from master (or main). For every new feature you add into your application, create a new feature branch from the dev branch. Note: Each of the steps below would make good feature branches. Keep your feature branches small and focused. They are your "safety net".
- Create a Product Model class for the content of products, including a single review. Its properties should include:
   - Id (make this of type int and just use arbitrary, unique numbers for these ids)
   - Name
   - Image
   - Category
   - Review
   - And whatever other things you'd like to include. Some ideas: Date or Description
- Create a ProductRepository class.
   - This class should be configured so that it will be injected into ProductController.
   - It should have a constructor that houses a List to store your products, using each product's id as the key.
   - For this sprint, all Product data should be hard coded in the List.
   - It should have a method, GetAll(), to get all products.
   - It should have a method, GetById(), to find one product by id.
- Create a ProductController class.
   - It should have an action that gets and returns all of your products in a Products Index View.
   - It should have an action that requires an id parameter to get and return one of your products in a Product Details View. This method should expect an "id" parameter in order to select a specific product.
- Create some Product Views.
   - A Product Index html view should display a list of all products on the web page.
   - Give the user a pathway to move back and forth from All Products to one Product. For example, they can select one Product from the list to see its details. The user can click a "All Products" button to return to the list of All Products.
   - A Product Details view will display details for one product on the web page, including its review.
   - Add some styling to your views. Don't forget, the views you present to the user should look nice!

## Sprint 2 Deliverables: Multiple Reviews for each Product

### User Stories

**Products Have Many Reviews**
- As a developer, I would like to create a table relationship between Products and Reviews, so that I can easily display Reviews that belong to a particular Product.
**Product Reviews View**
- As a user, I would like to see all Reviews for a chosen Product, so that I can determine if it is a good Product.

### Details

NOTE: Feel free to use appropriate class names other than Product and Review, but these instructions will refer to Product and Review.

A Product can have many Reviews.

For example:

| Product	| Review |
| ------- | ------ |
|Starbucks	| I like it, but its too expensive. |
|Starbucks	| Love it, I go there everyday! |
|Starbucks	| Overrated... |
|Dunkin	| Great, cheap coffee. And they have great donuts. |
|Arabica	| My original favorite, but stores are hard to find. |
|Arabica	| Love the atmosphere of this coffee shop. |

- Create a Review Model class for the content of reviews. Its properties should include:
   - Id (all models need a unique Id)
   - Content
   - And maybe: Reviewer name, Rating, Review date
- Update Product and Review Models for Entity Framework and Code First Migrations. Update the Product class such that:
   - It is an Entity Framework entity.
   - It configures a one-to-many relationship to Review.
- Update the Review class such that:
   - It is an Entity Framework entity.
   - It configures an appropriate relationship to its Product.
- Update the ProductRepository class.
   - Replace the Product List in your Repository with a DbContext database of Products.
   - Move seed data from the Repository to the DbContext by overriding the OnModelCreating() method.
- Create ReviewRepository and ReviewController classes.
   - Create appropriate Repository, Controller, and Tests to handle Review actions.
   - ReviewRepository should be configured so that it will be injected into the ReviewController.
   - Add a DbContext database of Reviews in the ReviewRepository.
   - Add seed data to the DbContext for Reviews.
- Create some Review Views
   - Update your Product Details view to list all Reviews for a chosen product.
   - OR, Create a separate Reviews Index view to display all reviews for a given product.
   
## Sprint 3 Deliverables: Use HTML forms to allow a user to add, edit and delete Reviews!

### User Stories

**Create Reviews**
- As a user, I would like to have the ability to add a Review to a Product, so that I can share my opinion.
**Edit Reviews**
- As a user, I would like to have the ability to edit a Review for a Product, so that I can change my mind or fix an error.
**Delete Reviews**
- As a user, I would like to have the ability to delete a Review for a Product, so that I can remove it.
**Navigation Links**
- As a user, I would like to have the ability to navigate off of every page I visit, so that I am not trapped on a page.

### Details

NOTE: You may need to modify the deliverables below based on the unique model design of your team's application. The deliverables below assume your data context consists of a one to many relationship between the Product Model class and the Review Model class.

- Update ReviewController and ReviewRepository.
   - Add CRUD (Create, Read, Update and Delete) actions to the appropriate controller and repository.
   - Make sure the controller has both Get and Post method types for these actions.
- Add Views and Navigation links.
   - Allow user to logically navigate to all the functions you have added to your program. 
   - NOTE: Some of these functions may be shown on the same page
      - List of all Products
      - Details for a Product
      - List of all Reviews for a given Product
      - Ability to Add a Product Review
      - Ability to Edit a Product Review
      - Ability to Delete a Product Review

### Stretch Task Deliverables

- Add Controller tests using NSubstitute.
   - Add Interfaces for all Repositories.
   - Add some Controller tests using the Interfaces and NSubstitute.
   - The number of tests is not important, just try to get some coverage with this new tool.
- Add CRUD operations and views for your Product.
- Add a Category class with a one-to-many relationship to your Product.

## Grading

Ideally, you should write your code by writing tests first. If you do so, each public method you write should have a unit test that covers its behavior. The test classes should also be well maintained and follow the principles of clean code.

75% of the public methods you add to your Product and Review classes should be covered by unit tests.
Tests include appropriate Arrange, Act, and Assert sections.
All tests pass.
