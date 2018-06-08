# ASP.NET MVC Hosted Vue.js Webpack Template

## Scope

A backend shell MVC application that contains ride-along API, and houses the transpiled Vue.js code in a Razor template.

This is powered by the `HtmlWebpackPlugin`, which leverages the use of a corresponding `[MVC-Action]Template.cshtml`
to generate the template with the injected transpiled css and js manifest references.

* ASP.NET 4.6.1
* WebAPI 5.2.3
* ASP.NET MVC 5.2.3
* Vue JS 2.5.2
* Babel Polyfill 6.26.0
* Bootstrap 3.3.7
* Vue Router 3.0.1
* Vuex 3.0.1
* Axios 0.18.0

## Purpose

To teams to get up and running a bit quicker with an ASP.NET MVC shell application hosting a Vue.js Webpack templated application.

## Team Objectives

* Clone the POC
* Set up Authentication
* Set up Database connections
* Set up any other configuration(s)
* Develop application

## Get Started

### Clone the POC

`git clone https://github.com/sjtipton/AspNetMvcHosted-VueWebpackPOC`

You now have a skeleton ASP.NET MVC-hosted Vue.js Webpack templated application that you can utilize to spin up (e.g. copy over to a new project folder and initialize a new repository with) to easily get started with.

### Setting Up Your IIS Endpoint Locally with this Repo

This POC is configured to use the IIS endpoint `/VueWebpackPoc/`, reachable on `http://localhost:80/` on the `DefaultAppPool`. No other settings are necessary, aside from pointing the application to the `AspNetMvcHost-VueWebpackPOC` **Project** once you have cloned it.
