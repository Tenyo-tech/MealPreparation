import { Link } from "react-router-dom"; 

const LatestMealCard = ({
    meal
}) => {
    return (
        <div class="game">
            <div class="image-wrap">
                <img src={meal.imageUrl} />
            </div>
            <h3>{meal.title}</h3>
            <div class="rating">
                <span>☆</span><span>☆</span><span>☆</span><span>☆</span><span>☆</span>
            </div>
            <div class="data-buttons">
                <Link to="/details" class="btn details-btn">Details</Link>

            </div>
        </div>
    );
}

export default LatestMealCard;