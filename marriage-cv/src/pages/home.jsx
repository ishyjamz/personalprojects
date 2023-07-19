import { Badge } from "react-bootstrap";
import AboutMeCard from "../components/about-me-card";
import EducationCard from "../components/education-card";
import FunQuestionsCard from "../components/fun-questions-card";
import '../components/cards.css';

function Home() {
    return (
        <>
            <div className="d-flex justify-content-center mt-3 mb-5">
                <h1>
                    <Badge bg="primary">
                        Ishtiak's Marriage CV
                    </Badge>
                </h1>
            </div>
            <div className="d-flex justify-content-center mt-5">
                <div className="me-5">
                    <AboutMeCard />
                </div>
                <div className="ms-5 me-5">
                    <EducationCard />
                </div>
                <div className="ms-5">
                    <FunQuestionsCard />
                </div>
            </div>
            <div>
            </div>
        </>
    )
}

export default Home;