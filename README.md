﻿# Software-Eng-Project-VR-Escape-Room
## Grace Reilly, Student ID: D00262395
## Brief Description: The VR escape room game is a simple level design, it is the first level of a VR escape room game set with one simple task of placing the cubes into the correct box in order for the 4 digit code to be revealed which then must be entered into the keypad code in order to complete the level. 

## Things that worked out:

| Attempt | Description |
| ------- | ----------- |
| 1.      | Implemented light flickering to create a broken light effect successfully. |
| 2.      | Added a stopwatch countdown, displaying a timer on a TV counting down from when the game begins. |
| 3.      | Added in teleport anchor. |

## Things that didn't work out:

| Attempt | Description |
| ------- | ----------- |
| 1.      | Attempted to create a whiteboard with a marker for interactive drawing, but faced challenges in achieving the desired functionality. |
| 2.      | Tried to implement a ladder-climbing mechanism, encountering difficulties in achieving smooth interaction for the hand controllers. |
| 3.      | Explored custom animated movement for VR hands, but struggled to get working.|
| 4.      | Added a Mixamo animation, but found that it didn't suit the intended style and atmosphere of the game. |
| 5.      | Designed a puzzle where three cubes fit into a container using a sockett interactable however didnt get the lid animation to work |
| 6.      | Developed a code keypad allowing players to enter a code, however I had issues with this also not working correctly. |

# Core Features of the VR Escape Room Game:

## Physics:

| Feature | Description |
| ------- | ----------- |
| Flashlight | - Added physics to the flashlight by attaching a Rigidbody component. |
| Cubes within Puzzle Container | - Implemented physics for three cubes with Rigidbody components. |
| Cabinet Drawer | - Enabled physics interactions for the cabinet drawer with a Rigidbody component, also used the hinge joint for this and adjusted the dampness/weight of the drawer. |
| Door | - Implemented physics for the door with a Rigidbody component and a hinge joint for controlled movement. |
| Marker | - Implemented physics for the marker and a grab point so the player would be up from a certain point. |

## Particle Effects:

| Feature | Description |
| ------- | ----------- |
| Rain Effect | - Added a particle effect for rain outside the building. |
| Fog Effect | - Added a particle effect for fog inside the VR escape room. |

## Materials & Shaders:

| Feature | Description |
| ------- | ----------- |
| Wood Material | - Applied wood material for the flooring |
| Glass Material | - Applied glass material for the windows in the room |
| Slime Material | - Applied slime material for specific a slime waterfall in the environment. |

## Audio:

| Feature | Description |
| ------- | ----------- |
| Background Music | - Added background music to play and loop throughout the game. |
| Reverb Radio | - Integrated a radio with a reverb zone for spatial audio effects. |
| Reverb Light Flickering Sound | - Utilized reverb zone for a couple of lights flickering that go on and off, with sound effects. |


## UI:

| Feature | Description |
| ------- | ----------- |
| Wrist Menu UI | - The user interface is attached to the players wrist. |
| Keypad Code UI | - when the player enters the correct code on the keypad which has buttons the player can press, the display panel will show what numbers have been entered and if it is the correct password or not. |
| Clock Countdown UI | - this element uses the **game manager** to set the time the clock count downs from. |



## Animations:

| Feature | Description |
| ------- | ----------- |
| Puzzle lid animate | - The idea for this is that the lid on the puzzle lifts up when the correct placement of the puzzle has been entered only then the lid of the puzzle lifts up. |

## OOD Design Principles:

| Feature | Description |
| ------- | ----------- |
| Puzzle Script **Encapsulation** | - The puzzle script includes encapsulation by using private fields example 'NumberOfClassToComplete'. Also the private methods such as 'CheckForPuzzleCompletion' as they can only be accessed within the puzzle manager class. |
| Puzzle Script **Encapsulation** | - The puzzle script includes encapsulation by using private methods for example 'PuzzlePieceRemoved'. |
| Light Flickering Script **Encapsulation** | - The light flickering script includes encapsulation by using public field for 'lightOB' and 'lightSound'. |
| Light Flickering Script **Composition** | - The light flickering script includes composition as it has existing components from unity such as audioSource and Light. |
| Light Flickering Script **Encapsulation** | - The light flickering script includes encapsulation by using private fields such as 'minTime' & 'timer'. |



| No. | Youtube Tutorials |
| ------- | ----------- |
| 1. | - https://www.youtube.com/watch?v=YISa0PvQTGk&ab_channel=FistFullofShrimp |
| 2. | - https://www.youtube.com/watch?v=iSYfs6NXZck&t=1466s&ab_channel=DanielStringer |
| 3. | - https://www.youtube.com/watch?v=-YZtDzdvNJ4&t=227s&ab_channel=DanielStringer |
| 4. | - https://www.youtube.com/watch?v=hz_iVyYO-MY&t=17s&ab_channel=DanielStringer |
| 5. | - https://www.youtube.com/watch?v=1qu1CiiJGAw&ab_channel=20Nik |
| 6. | - https://www.youtube.com/watch?v=sHE5ubsP-E8&t=479s&ab_channel=JustinPBarnett |
| 7. | - https://www.youtube.com/watch?v=ZPJpTmNBZIQ&t=872s&ab_channel=DanielStringer |
| 8. | - https://www.youtube.com/watch?v=8pgi1TBGCKM&t=988s&ab_channel=UnityVirtualProduction%26Filmmaking%28HDRP%2BURP%29 |
| 9. | - https://www.youtube.com/watch?v=MBVGUD5nZeA&ab_channel=LordEvilM44 |
| 10. | - https://www.youtube.com/watch?v=1JZ62Us3RI0&t=12s&ab_channel=FistFullofShrimp |
| 11. | - https://www.youtube.com/watch?v=bYS35_hC6B0&t=253s&ab_channel=Valem |
| 12. | - https://www.youtube.com/watch?v=oOmAB0rs518&t=140s&ab_channel=User1Productions |
| 13. | - https://www.youtube.com/watch?v=8xIxXkXn26M&ab_channel=FistFullofShrimp |
| 14. | - https://www.youtube.com/watch?v=ExHHhei6fnw&t=8s&ab_channel=StudioHamlin |
| 15. | - https://www.youtube.com/watch?v=uOhWT6TxZgE&ab_channel=GabrielAguiarProd. |
| 16. | - https://www.youtube.com/watch?v=Bg6C7N5V-aI&ab_channel=RyanMurray |
| 17. | - https://www.youtube.com/watch?v=-2Aww2raAws&ab_channel=SwishSwoosh |





