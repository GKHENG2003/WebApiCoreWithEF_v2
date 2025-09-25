update credential in conn-string of ~\\WebApiCoreWithEF\\WebApiCoreWithEF\\appsettings.json



run the following command to create a migration of CompanyContext.

PM> add-migration MigrationV1

remove the created migration by running the below command in the Package Manager console.

PM> remove-migration

Run the following command in the Package Manager console.

PM> update-database





GET https://localhost:5001/api/Book

POST https://localhost:5001/api/Book, body:

 

{

        "title": "The Catcher in the Rye",

        "year": 1952,

        "genre": null,

        "genreId": 5,

        "authorId": 5,

        "author": null,

        "isDeleted": false

}



PUT https://localhost:5001/api/Book/5, body:



{

        "id": 5,

        "title": "The Catcher in the Rye",

        "year": 1952,

        "genre": null,

        "genreId": 5,

        "authorId": 5,

        "author": null,

        "isDeleted": false

    }



DELETE https://localhost:5001/api/Book/6



POST https://localhost:5001/api/Book/addBorrowableBook, body:

 

{

        "BookId": 5,

        "Quantity": 10

}



POST https://localhost:5001/api/Book/borrowBook, body:

 

{

        "book": {

                    "id": 5,

                    "title": "The Catcher in the Rye",

                    "year": 1952,

                    "genre": {

                                    "Id": 5,

                                    "Name": "Horror"

                            },

                    "authorId": 5,

                    "author": null,

                    "isDeleted": false

                }

            ,

        "memberId": 6,

        "membershipDuration": 15

}



POST https://localhost:5001/api/Book/returnBook, body:



{

        "book": {

                    "id": 5,

                    "title": "The Catcher in the Rye",

                    "year": 1952,

                    "genre": {

                                    "Id": 5,

                                    "Name": "Horror"

                            },

                    "authorId": 5,

                    "author": null,

                    "isDeleted": false

                }

            ,

        "memberId": 6

}

