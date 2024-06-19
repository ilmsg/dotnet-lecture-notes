# dotnet-lecture-notes
dotnet lecture notes

### webapi with controller

    $ dotnet new webapi -o webapi-controller
    $ cd webapi-controller
    $ dotnet watch run -lp http

parameter ที่เป็น -lp, --launch-profile คือระบุเลือก launch profile. ในที่นี้เลือกเป็น http จะมี port มาให้เลย

ดูอ้างอิงจากไพล์ `Properties\launchSettings.json`

[http://localhost:5117/swagger/index.html](http://localhost:5117/swagger/index.html)
---
![/images/2024-06-19_193436.png](/images/2024-06-19_193436.png)
---
![/images/2024-06-19_193555.png](/images/2024-06-19_193555.png)