import page from "./node_modules/page/page.mjs";
import homePage from "./pages/home/homePage.js";
import nav from "./pages/nav/nav.js";
import { LitRenderer } from "./rendering/litRenderer.js";
import authService from "./services/authService.js";
import mealsService from "./services/mealsService.js";

let navElement = document.getElementById("nav");
let appElement = document.getElementById("main-content");

let renderer = new LitRenderer();

let navRenderHandler = renderer.createRenderHandler(navElement);
let appRenderHandler = renderer.createRenderHandler(appElement);

nav.initialize(page, navRenderHandler, authService);
homePage.initialize(page, appRenderHandler, mealsService);


page("/index.html", "/home");
page("/", "/home");

page(decorateContextWithUser)
page(nav.getView)

page("/home", homePage.getView)

page.start();

function decorateContextWithUser(context, next){
    console.log(context);
    let user = authService.getUser();
    context.user = user;
    next();
}