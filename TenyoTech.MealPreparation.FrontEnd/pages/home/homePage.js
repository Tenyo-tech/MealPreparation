import { homeTemplate } from "./homeTemplate.js";


let _router = undefined;
let _renderHandler = undefined;
let _gamesService = undefined;

function initialize(router, renderHandler, gamesService) {
    _router = router;
    _renderHandler = renderHandler;
    _gamesService = gamesService;
}

async function getView(context) {
    let recentGames = await _gamesService.getRecentGames();
    let templateResult = homeTemplate(recentGames);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}