# Software Requirements Specification

## Functional Requirements

### Message Encryption

1. Each chat should have its own Encryption key.
2. Each Multi-user chat should use Symmetric Keys.
3. Each Direct user chat should use Asymmetric Keys.

### Front-End Requirements

1. Must be Written in Angular
2. Must be similar to Telegram
3. Must Have a Profile Page
4. Must Have Channel Search
5. Must Have Chat Search
6. Must Have Image Preview
7. Must Have Video Preview
8. Must Have Emojis

### Chat History Component

1. Must show most recent message.
2. Must show whether the message has been sent/received/read.
3. Must enter Chat page on click.
4. Must lead to a Direct Message Screen + a Channel Page.

### Chat Component

1. Should show messages.
2. Should allow you to search for messages.
3. Should allow you to type messages.
4. Should allow you to post emojis.
5. Should allow you to post files.
6. Files should allow for image and video preview.
7. Files should be downloadable.
8. Links should have Link Preview.

### Sidebar Component

1. Should lead to Profile.
2. Should lead to Settings.
3. Should lead to Logout.

#### Profile Component

1. Should show an Image.
2. Should let you change the Image.
3. Should let you change your details.

#### Settings

1. Must allow for theme change.
2. Must allow for dark mode.
3. Must allow for account deletion.
4. Must allow for viewing Cryptographic keys stored in the Front-end.
5. Must allow for changing Cryptographic keys stored in the Front-end.

### Back-End

1. Must be able to store Files
2. Must be able to store Messages
3. Must be able to Authenticate via Microsoft and Google

#### Cryptography: How are keys passed and stored?

## Non-Functional Requirements

1. Front-end must look like Telegram
2. 10 Mill > 1 Mill > 100k messages per second from users
3. All Messages to be Encrypted
4. OAuth 2 Flow - Microsoft, Google

## Constraints

1. Has to work using the following Technologies:
   1. C#
   2. TS
   3. Angular
   4. Kafka
   5. Microsoft SQL Server
   6. Docker
2. Must use a Database per service.
3. Must be exposed to the internet.
