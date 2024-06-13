# DemographicsGenerator

A learning project to output simple demographics information.

## Status

This project is a **work in progress**.

## Overview

This is a simple project for me to practice object oriented programming in C#. My main focus here was learning how to interact with JSON files and turn them into class objects.

This program defines a `Person` object that consists of several strings selected from JSON files. The goal is to build a randomly generated "profile" of a person.

The end goal of this program is to use as a fun tool for worldbuilding or in table-top role playing games. If I have a bank of data for a specific world I'm writing about, I can populate it in this program and generate basic characters on the fly.

## Learning objectives

| Learning objective | What I've learned                                                                                                                                                                                                                                                        |
| ------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Information design | This project has primarily been an exercise in designing a data model. The central piece of this is the `Person` object, which consists of various classes. I've learned the basics of setting up classes to create a coherent object containing methods and parameters. |

## Improvements (to do)

The basic functionality of generating a profile by randomly selecting attributes is complete. I also want to work on the following features:

- [ ] Implementing logic to make a person's attributes less random (education affecting occupation, for example)
- [ ] Implementing name generation
- [ ] Adding additional detail to the various classes that make up a Person.
