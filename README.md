# Setup
Create a MySQL database with the files in the `/SQL` directory.
`DB.sql` creates all the empty tables.
`MOCKDATA.sql` adds data to the tables to run tests with.
For now, the controller gets initialized in the `/AllInPoker/Views/ActiveTournamentView.cs` file (at the bottom). Here you can change your database login info.

The default login info is:
- server: `localhost`
- database: `allin_poker`
- uid (username): `root`
- password: `root`
