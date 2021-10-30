
## User

### Properties
- ```int Id``` get  
- ```string Username``` get/set
- ```string Password``` get/set
- ```string FullName``` get/set
- ```string Email``` get/set
- ```string PhoneNo```get/set
- ```string Ic``` get/set
- ```Roles Role```get/set
- ```DateTime? DateOfBirth``` get/set

#### ```enum Roles```
  - ```Customer``` = 0
  - ```Administrator``` = 1
  - ```Receptionist``` = 2
  - ```Technician``` = 3


### Methods
#### ```User.Update()```
```c#
User myUser = User.GetById(0)
myUser.FullName = "James"
myUser.Update();
```
To update a user to dataabse.

**Returns**
- ```void```


### Static Methods

#### ```User.Save()```
```c#
User.Save(string username, string fullName, string email, string password, string phoneNo, Roles role)
```
To create a user object and save it to database.

**Returns**
- ```User```
  
<br/>

#### ```User.GetByUsername()```
```C#
User.GetByUsername(string username)
```

To retrive a user from database by username.
 
##### Returns
- ```User``` when a user is found.
- ```null``` when no user is found.

<br/>

#### ```User.GetById()```
```C#
User.GetById(int id)
```
To retrieve a user from database by userId.

##### Returns
- ```User``` when a user is found.
- ```null``` when no user is found.

<br/>

#### ```User.GetByEmail()```
```C#
User.GetByEmail(string email)
```
To retrieve user from database by email from database.

##### Returns
- ```User``` when a user is found.
- ```null``` when no user is found.

<br/>

#### ```User.GetByRole()```
```C#
User.GetByRole(Roles role)
```
To retrieve user from database by email from database.

##### Returns
- ```User[]``` an array of users, empty when nothing is found.

<br/>

## Service
### Properties
- ```private static Service[] services```
- ```public int Id { get; }```
- ```public string Name { get; }```
- ```public double Price { get; }```
- ```public double UrgentPrice { get; }```

### Static Methods

```Service.GetService()```
```C#
Service.GetService(int id)
```
To get service by service id.
##### Returns
- ```Service``` object.

<br/>

## IncompleteService
### Properties
- ```public User User { get; }```
- ```public Service Service { get; set; }```
- ```public bool Urgent { get; set; }```
- ```public DateTime DateTimeCreated { get; set; }```

### Methods

#### ```Update()```
```C#
IncompleteService s = IncompleteService.Save(myUser, service, false);
s.Service = Service.GetService(5);
s.Update();
````
To update the database.
##### Returns
- ```void```

<br/>

#### ```Delete()```
```C#
IncompleteService s = IncompleteService.Save(myUser, service, false);
s.Delete();
````
To delete a row from database.
##### Returns
- ```void```

<br/>

### Static Methods

#### ```GetAll()```
```C#
IncompleteService[] services = IncompleteService.GetAll();
```
To get all the incomplete services from database.
#### Returns
- ```IncompleteService[]```

<br/>

#### ```GetByUser(User user)```
```C#
IncompleteService s = GetByUser(User.GetById(5));
```
To get all the incomplete services from database.
#### Returns
- ```IncompleteService[]```

<br/>

## CompletedService
### Properties
- ```public int Id { get; }```
- ```public User User { get; }```
- ```public User CompletedBy { get; }```
- ```public Service Service { get; }```
- ```public bool Urgent { get; }```
- ```public string Description { get; }```
- ```public bool HasPaid { get; set;}```
- ```public DateTime DateTimeCreated { get; }```
- ```public DateTime DateTimeCompleted { get; }```

### Methods
#### ```Update()```
```C#
completedService.Update();
```
To update the database with new data.  
Since only ```HasPaid``` is changeable, only ```hasPaid``` will be updated to the database.
##### Returns
- ```void```

<br/>

### Static Methods

#### ```CompletedService.Save(IncompleteService incompleteService, User completedBy, string description)```
```C#
CompletedService compService = CompletedService.Save(incompleteService, User.GetById(5), "Warranty 2 years");
```
To create a ```CompletedService``` from ```IncompleteService```
##### Returns
- ```CompleteService```

<br/>

#### ```CompletedService.GetById(int id)```
```C#
CompletedService compService = CompletedService.GetById(1);
```
To create a ```CompletedService``` from ```IncompleteService```
##### Returns
- ```CompleteService```
- ```null``` when not found

<br/>

#### ```CompletedService.GetByUser(User user)```
```C#
CompletedService compService = CompletedService.GetByUser(User.GetById(3));
```
To create a get user's completed services from database.
##### Returns
- ```CompleteService[]```

<br/>

#### ```CompletedService.GetUnpaidCount(User user)```
```C#
CompletedService compService = CompletedService.GetByUser(User.GetById(3));
```
To get the number of completed services of a user where payment hasn't been made.
##### Returns
- ```int```




