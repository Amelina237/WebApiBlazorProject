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
   
   ![g2](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/1b3f5080-ce2c-4ac7-ae0e-fffca961941d)
   
5. Choose **Multiple Startup Projects** and on the Action Tab set **Start** for both Blazor and Api
   
   ![g3](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/1bbaf9c5-7f9e-46bc-b8bd-09f2b653554c)
   
6. Run the application by clicking on Start. It will open tab Swagger and Blazor UI at the same time
 
   ![start](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/e7f96ae4-10a1-4c6e-806c-723bef5a2c34)

7. Open DB Browser then click Open Database. Choose the path of Weather.db in the Data folder.
   
8. To view the list of data right click on 'weathers' and then choose Browse Table

   
## Screenshot of the application :

1. Main Page :

![main page](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/741943c7-a110-4cc7-b7d2-9c1301136889)

2. Display weather forecast data by entering value of latitude and longitude :

![search](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/0d5e8cc1-5821-45ab-962b-80d6fde1963f)

3. List of Data

![2 List](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/b3523a54-5a16-4c7f-9d54-118f85b0906c)

4. Add Page

![3 Add](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/91b834d6-2991-4a3f-977b-f3b1d16d0136)

- Checking duplicate data - if there are same data of latitude, longitude, and city name, it will display a warning alert message

5. View Page

![4 View](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/88d8617b-a412-471c-91b3-1d82dd4de0b4)

6. Edit Page

![5 edit](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/dc4c84db-b76e-42e1-a9f3-5fa529f3907b)

7. Delete

![6 delete](https://github.com/Amelina237/WebApiBlazorProject/assets/33069266/629a4bf5-70dc-4fe6-b705-71923ef89fc3)

**Additional - This application also includes **Data Validation** checking for the input type
