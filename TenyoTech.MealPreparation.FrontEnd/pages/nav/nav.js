import { navTemplate } from "./navTemplate.js";


let _router = undefined;
let _renderHandler = undefined;
let _authService = undefined;

function initialize(router, renderHandler, authService) {
    _router = router;
    _renderHandler = renderHandler;
    _authService = authService;
}

async function logoutHadnler (e) {
    await _authService.logout();
    _router.redirect("/home");
}

async function getView(context, next) {
    let user = context.user;
    let email = user !== undefined ? user.email : undefined;
    let navModel = {
        isLoggedIn: user !== undefined,
        email,
        logoutHadnler
    }
    let templateResult = navTemplate(navModel);
    _renderHandler(templateResult);
    next(); 
}

export default {
    getView,
    initialize
}