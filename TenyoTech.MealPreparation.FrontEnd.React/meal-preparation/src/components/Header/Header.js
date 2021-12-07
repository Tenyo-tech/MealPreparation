const Header = () => {
    return (
        <header>
            <h1><a class="home" href="#">Meal Preparation</a></h1>
            <nav>
                <a href="#">All Meals</a>
                <div id="user">
                    <a href="create">Create Meal</a>
                    <a href="#">Logout</a>
                </div>
                <div id="guest">
                    <a href="#">Login</a>
                    <a href="#">Register</a>
                </div>
            </nav>
        </header>
    );
}

export default Header;