## Project Requirements :

- Framework .Net 6.0

- DB Browser for SQL Lite

- Microsoft Visual Studio Community 2022
  
## User Guide Installation :

1. Download and install DB Browser SQL Lite at this link: https://sqlitebrowser.org/dl/
2. Open Microsoft Visual Studio and choose **'Clone a repository'**
3. Enter the Github link in the 'repository location': **https://github.com/Amelina237/WebApiBlazorProject.git**
   
   ![firstgit](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/d8994b93-065b-4520-b956-48b89c1ef677)
   
4. Right-click on the Solution and choose Configure Startup Projects
   
   ![g2](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/0c58e95b-df05-4023-b9c6-ef7e39a94bb2)
   
5. Choose **Multiple Startup Projects** and on the Action Tab set **Start** for both Blazor and Api
   
   ![g3](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/ef23cb27-b976-43af-9372-e9d525288822)
   
6. Run the application by clicking on Start. It will open tab Swagger and Blazor UI at the same time
 
   ![start](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/bb7e18ff-7895-4fa9-82ef-c30ea6074887)

7. Open DB Browser then click Open Database. Choose the path of Weather.db in the Data folder.
   
8. To view the list of data right click on 'weathers' and then choose Browse Table

   
## Screenshot of the application :

1. Main Page :

![main page](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/9b99e21e-87e5-4590-8363-04feb80c45df)

2. Display weather forecast data by entering value of latitude and longitude :

![search](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/4176a276-6e3a-476d-8d1d-4e91dfd2bca7)

3. List of Data

![2 List](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/840625bc-e2fa-4ab8-8061-c463ceae9bf9)

4. Add Page

![3 Add](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/d1ddb0a0-a7c6-426a-b4a5-48f970505d0c)

- Checking duplicate data - if there are same data of latitude, longitude, and city name, it will display a warning alert message

5. View Page

![4 View](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/a4f02bbb-c7ba-4aa9-b893-7f12444e76ee)

6. Edit Page

![5 edit](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/24dcf3ed-5a68-47da-9ad3-2bd3d6deca51)

7. Delete

![6 delete](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/8033d1e7-b703-4e5a-99c9-19051f2efdf1)

**Additional - This application also includes **Data Validation** checking for the input type
