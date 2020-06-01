# BAGMAN

This is a bot that will help manage events in the Discord server Artoholics Anonymous.

This bot will have the following convenience features:

* Create and maintain numerous multi-stage events.
  * These events usually have the same format. In the first stage, participants submit one thing, and in the next stage, they will receive a random participant's entry and create a new submission based on the previous stage. Think of events like Switcharound, Poster Shoot, and AA Radio. Each stage has a particular deadline that participants have to reach.
  * Edit and manage events.
* Manage user submissions.
  * Users can ask the bout about deadlines and how much time they have left.
  * Users can submit as many images/files as they want (within reason of course)
  * Event maintainers can keep track of all submissions via a spreadsheet.
* Manages reveal parties.

## COMPONENTS

### CORE

The Core contains most of the fundamental data types for the program, such as Events, Participants, and Submissions.

### SERVER

The Server is the backend of Bagman bot and handles all the incoming requests.

### BOT

The Bagman bot is the Discord frontend to Bagman. This is how users will mostly interact with Bagman, and they can 

### WEB CLIENT

The web client is the web frontend to Bagman. This is how event maintainers will mostly interact with Bagman. Provides an interface for creating and managing events, and also keeps track of submissions.

### CONSOLE CLIENT

Quick way to manage the bot from the command line.

## MAINTAINERS

* Feki `Feki#1165`
* Silber `Silber#1470`
* Limelier `limelier#5113`
