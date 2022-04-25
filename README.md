# Pico Placa Predictor

<p>This is a Web App developed with ASP.Net Core 6.</p>

<p><a href="https://picoplacapredictor.azurewebsites.net/">You can check the demo in the following link</a></p>

<p>The main purpose of this app is to determine if a plate number can circulate given a date and time.</p>

<p>The structure of the project is as follows:
Controller: Contains the main controller that communicates with the view
Model: Contains all objects required by the system
Data: A class that pretends to be the database
Service: This layer contains all the business logic, that is, the Pico Placa prediction logic.</p>

<p>The parameterization contained in the system is based on the traffic rules of Quito-Ecuador, therefore the following restrictions exist:</p>
<ul>
    <li>Monday can't be on road plate numbers ending in 1,2 in the schedules 7:00-9:30,16:00-19:30</li>
    <li>Tuesday can't be on road plate numbers ending in 3,4 in the schedules 7:00-9:30,16:00-19:30</li>
    <li>Wednesday can't be on road plate numbers ending in 5,6 in the schedules 7:00-9:30,16:00-19:30</li>
    <li>Thursday can't be on road plate numbers ending in 7,8 in the schedules 7:00-9:30,16:00-19:30</li>
    <li>Friday can't be on road plate numbers ending in 9,0 in the schedules 7:00-9:30,16:00-19:30</li>
</ul>
    
<p>There is also support for holidays since according to the traffic rules, the following days are exempt from Pico Placa:</p>
    
<ul>
    <li>New year: 1/1/2022</li>
    <li>Carnival: 28/2/2022</li>
    <li>Carnival: 1/3/2022</li>
    <li>Good Friday: 15/4/2022</li>
    <li>Labor day: 1/5/2022</li>
    <li>Battle of Pichincha: 23/5/2022</li>
    <li>Founding of Guayaquil: 25/7/2022</li>
    <li>Ecuador's first cry of independence: 12/8/2022</li>
    <li>Independence of Guayaquil: 10/10/2022</li>
    <li>All Souls' Day: 3/11/2022</li>
    <li>Independence of Cuenca: 4/11/2022</li>
    <li>Founding of Quito: 6/12/2022</li>
    <li>Christmas: 26/12/2022</li>
</ul>

<p>* Restrictions and holidays can be parameterized in the following route: Data/DataPicoPlaca.cs</p>

<p>Software developed by José Antonio Guerra Cajas</p>
