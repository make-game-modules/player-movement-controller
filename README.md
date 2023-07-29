# Unity Player Movement Controller

[中文](https://github.com/make-game-modules/player-movement-controller/blob/main/README.zh-cn.md)

This project provides a Unity script that enables basic player movement control. It allows player character to move up, down, left, or right using arrow keys or W, A, S, D keys.

## How to Install

In your Unity project, clone this repository at any location using Git.

## How to Use

Add the `PlayerMovementController` script to the player object. You can set the player's movement speed parameter in the Inspector window of the Unity editor.

## Parameter Settings

- `speed`: This is a public float variable used to control the player's movement speed. It can be adjusted in the Unity editor.

## Operating Principle

- Get the horizontal and vertical inputs to create a 2D vector, representing the direction and magnitude of movement.
- Use the created vector to move the player. Multiply by the `speed` variable to control the movement speed.
- Multiplying by `Time.deltaTime` (the time of the last frame) ensures consistent player movement speed across various devices, regardless of the frame rate.

## Copyright Information

This project uses the MIT open source license. Everyone is welcome to improve and use the project.
