# Online Food Ordering System

## Main Pages 
  - Home
  - Abuat us
  - Contact us
  - User profile (as user image)
  - Cart
  - Search
  - login
  - register
  - **Dashboard**
    - Add Product  
    - Edit Product  
    - Add Admin (if You are Super Admin)  
    - Delete Admin (if You are Super Admin)
    - receiver the orders
      - it is vary simple than it should at real world.
      - as it should build as real time system with SignalR with notifcation.
    - Statistics
      - Number of users
      - 5 high rating food


    
## Sheard Layout Componant 
  - Hearder nav
  - Footer
  - 
## partial view Componant 
  - Hearder nav
  - Footer
  - Product container
  - Product card
    
## Hearder Nav (create it as partial view)
  -Links to
    -Home
    -Abuat us
    -Contact us
    -User profile (as user image)
    -Cart
  - Brand Name ("Elghool Food")
  - Search Icon

## Footer (create it as partial view)
  - Social media icons
  - Slogan ("Be Happy")

## Home Pages (create it as view)
  - Header
  - Filter 
  - Product container (create it as partial view)
    - Product card (create it as partial view)
      - Product img
      - Price
      - Discount
      - Add To card Button
  - Footer      

## Abuat us Pages (create it as view)
  - Header
  - Group of section (width 100% with fixed hieght) 
    - section #1
      - title ("very high quality")
      - paragraphe ("We work hard with the latest technology and the most skilled chefs to increase quality and provide you with the best service")
      - illstration chef image or some think that indecat to "**latest technology**"
    - section #2
      - title ("very fast delever")
      - paragraphe ("We have a team of the fastest Delivery Drivers and branches all over the world")
      - illstration to "Delivery Driver"
    - section #2
      - title ("Be Happy")
      - paragraphe ("Our goal is to make you happy so smile")
      - illstration to "smile"
  - Footer

   ## Contact us Pages (create it as view)
   - Go To Footer

## User profile Pages (create it as view)
  - User Image
  - user name
  - user email
  - logout
  - change the passeard
  - login with other account

## Cart Pages (create it as view)
  - prouct card
    - prouct image
    - prouct name
    - prouct price of uint
    - prouct quntity
    - price * quntity
  - Total price
  - Check out Button

## Search Pages (create it as view)
  - Search input
  - Product container (create it as partial view)
    - Product card
      - Product img
      - Price
      - Discount
      - Add To card Button
        
## login Pages (create it as view)
  - User Email input (Tage Helper)
  - User password input (Tage Helper)

## register Pages (create it as view)
  - User Email input (Tage Helper)
  - User password input (Tage Helper)
  - User confirm password input (Tage Helper)
  - User address input (Tage Helper)




# Database Model (create it with Code Frist)
User 
cart
food
Rating
role
