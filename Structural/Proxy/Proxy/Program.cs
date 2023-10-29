using Proxy;

IStudent obj = new StudentProxy();
obj.CreateStudent("HR");
obj.CreateStudent("ADMIN");
obj.CreateStudent("ACCOUNTS");
obj.DeleteStudent("ADMIN", 4);
obj.DeleteStudent("USER", 10);
