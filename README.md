# ImageResizer
<a name="readme-top"></a>


[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]


<!-- PROJECT LOGO -->
<br />
<div align="center">
  ![image](https://user-images.githubusercontent.com/120386306/236635519-d53f481f-8c81-4389-86d1-ca58590a85c1.png)


  <h3 align="center">Image Resizer by Erdajt Sopjani</h3>

  <p align="center">
    An awesome Image Resizer you can call anywhere from your terminal!
    <br />
    <br />
    <a href="https://github.com/ErdajtSopjani/ImageResizer">View Demo</a>
    ·
    <a href="https://github.com/ErdajtSopjani/ImageResizer/issues">Report Bug</a>
    ·
    <a href="https://github.com/ErdajtSopjani/ImageResizer/issues">Request Feature</a>
  </p>
</div>


<!-- ABOUT THE PROJECT -->
## About The Project


There are really good Image Resizer's anywhere you look. But i decided to make one that both saves time and is easily accessable. I think I did a really good job achieving this since you can call this program anywhere from the terminal. But firs you have to run the .exe so it gets added to your file path. I think this project will save a lot of people their time.

Here's why:
* You can call it from anywhere using your terminal
* It's fast and it does the resizing quick.
* It saves the resized image in the same directory you are working on so you dont have to search for the file.
* It has no limitations unlike other Resizers

Of course this program isn't going to be loved by everyone but the most important thing is I like it and it saves ME a lot of time in my daily life.
Keep in mind this was only a begginer project i did as a way to test my skills while learning c#.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With

This project was made with C# with DotNet core

[![Bootstrap][Bootstrap.com]][Bootstrap-url]

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

Here are a couple of steps you can follow to get started with using ImageResizer

### Installation

  Here is a step-by-step guide on how you can run this program on your own device

1. Make sure you have dotnet installed (only if you want to run it with dotnet)
2. Clone the repo
   ```sh
   git clone https://github.com/ErdajtSopjani/ImageResizer.git
   ```
3. Install NPM packages(if you want to run it with dotnet)
   ```sh
   dotnet add package System.Drawing.Common --version 5.0.0
   ```
4. If you only want to run this program you can run the .exe from your terminal
   ```js
   .\resizeimage.exe -h;
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

These are some usage examples for this program.

1. If you want more information on how to use it use -h
  '''sh
  resizeimage -h
  '''
2. If you want to know an Image's width and height before you resize it use -i
  '''sh
  resizeimage -i null
  '''
3. If you want to actually resize an image this is the use case: 
  '''sh
  resimeimage C:/path/to/image.png {width} {height}
  '''

<p align="right">(<a href="#readme-top">back to top</a>)</p>




<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/ErdajtSopjani/ImageResizer?style=for-the-badge
[contributors-url]: https://github.com/ErdajtSopjani/ImageResizer/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/ErdajtSopjani/ImageResizer?style=for-the-badge
[forks-url]: https://github.com/ErdajtSopjani/ImageResizer/network/members
[stars-shield]: https://img.shields.io/github/stars/ErdajtSopjani/ImageResizer?style=for-the-badge
[stars-url]: https://github.com/ErdajtSopjani/ImageResizer/stargazers
[issues-shield]: https://img.shields.io/github/issues/ErdajtSopjani/ImageResizer?style=for-the-badge
[issues-url]: https://github.com/ErdajtSopjani/ImageResizer/issues
[Bootstrap.com]: https://img.shields.io/github/languages/top/ErdajtSopjani/ImageResizer?color=purple&style=for-the-badge
[Bootstrap-url]: https://dotnet.microsoft.com/en-us/download
