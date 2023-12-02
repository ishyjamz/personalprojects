import { Button } from "react-bootstrap"
import { Link } from "react-router-dom"

function FunQuestionsPage() {
    function startQuiz() {

    }



    return (
        <>
            <div className="d-flex justify-content-center mt-3 mb-5">
                <h1 style={{ fontSize: "48px", fontWeight: "bold" }}>
                    Are you ready to begin the compatibility quiz?
                </h1>
            </div>
            <div className="d-flex justify-content-center mt-5">
                <Link to='/quiz'>
                    <Button variant="primary" 
                    style={{ width: "300px", height: "100px", fontSize: "30px" }}>
                        Let's go
                        </Button>
                </Link>

            </div>

        </>
    )
}

export default FunQuestionsPage