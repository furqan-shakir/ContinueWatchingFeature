
## Continue Watching Feature
We want to implement a continue watching feature for movies and series so that unfinished movie or series is shown for the user in the “continue watching” list, data will be sent from user client apps in interval of 10 seconds that contains
Userid
Movie/episode id
Type (movie or series)
Seek Position 

We want to design an efficient implementation of such feature so that datatore (DB) can scale (since there will be a lot of data sent from clients for 1M user)

The feature should include the following 
To only include titles that has been started by the user 
To remove titles that has crossed 90% of the title duration
To remove series if the series episodes are finished (including all seasons)

## Data seed
You will need to implement data seed for the feature that have

100k movie and series with random names and random number of seasons and episodes
Movie/episode duration is set random (between 1-2 hours)
100 user
1M random seek position with other metadata

## Tech stack
Asp.net core is to be used as a programming language, as for db you have to decide what db(s) can handle such feature without bottle necks
No ui is needed

## Solution
Based on the previous user stories, this application will receive two types of queries: 
1- Browse movies and series categorized by seasons, This type of query better relay on normalized data, which has been implemented by MySQL DB.
The relational db is handeling the users, series, season, and videos entites. 
2- Watch movies or series, This request will rely on many joins if it was depending on high normalized data or relational database. 
Denormalization here is the key to avoid such joins, I decided to use Mongodb to be responsible for handling the WatchingList collection which is responsible for 
storing the watch document, which includes information about watched items such as the seek position and nested user, video, season, and series documents.
Also, In terms of scalability, MongoDB supports horizontal scaling through sharding.

## About the code
- The `MovieService` responsible for encapsulating the logic that deals with Mongodb. The `MovieService` class is registered with DI to support constructor injection in consuming classes such as the controllers. The registration process was done through singleton.
- The `MoviesDatabaseSettings` class is responsible for storing the settings of the Mongodb that comes from the appsetting.json file.
- The `ModuleBuilderExtension` class is responsible for seeding the data

## Run
Run the migrations to seed the data by using the cli `dotnet ef database update` in the project directory, then run the application by using `dotnet run`, a swagger window will open, you can use to try the api out.




