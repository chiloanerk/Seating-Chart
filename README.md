# Seating Chart Application

The Seating Chart Application is a Windows Forms application that simulates a seating chart for a flight. It allows users to manage seat reservations, add passengers, and handle waiting lists for occupied seats.

## Features

- 10x4 Seating Chart: The application displays a 10x4 seating chart using a ListBox. Each row represents a specific row of seats on the flight, and each column represents a seat (A, B, C, D) in that row.

- Add Passenger: Users can add passengers to the seating chart by providing the passenger's name and the desired seat number (e.g., 1A, 2B, 10D). If the seat is available, the passenger is assigned to that seat, and the seating chart is updated. If the seat is already taken, the passenger is added to a waiting list.

- Delete Passenger: Users can remove passengers from the seating chart by entering the passenger's name. If the passenger is found, the seat is vacated, and the seating chart is updated. If the waiting list is not empty, the next passenger on the waiting list is automatically assigned to the vacant seat.

- Waiting List: The application maintains a waiting list for passengers who couldn't get their desired seats initially. The waiting list is displayed in a separate ListBox, and when a seat becomes available due to a passenger deletion, the next passenger on the waiting list is automatically assigned to that seat.

- Data Persistence: The application can save the current state of the seating chart (occupied seats) and the waiting list to a file named "reservations.txt" when the application is closed. Upon launching the application, it loads the previously saved reservations, allowing for continuity between sessions.

## How to Use

1. Launch the application (SeatingChart.exe).

2. To add a passenger, enter the passenger's name and the desired seat number (e.g., 1A, 2B, 10D) in the respective textboxes. Click the "Add Passenger" button.

3. To remove a passenger, enter the passenger's name in the textbox and click the "Delete Passenger" button.

4. The seating chart will be updated with the passenger assignments, and the waiting list will display passengers waiting for occupied seats.

5. To quit the application, click the "Quit" button.

## Dependencies

The application is built using the .NET 6 LTS Framework and Windows Forms. There are no additional external dependencies required to run the application.

## License

This project is licensed under the [GNU License](LICENSE).

## Authors

- [Relebogile Chiloane](https://github.com/chiloanerk) 
