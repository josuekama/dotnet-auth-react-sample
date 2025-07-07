import { Navigate } from "react-router-dom";
import { useGetUserQuery } from "../services/api";

function Home() {
    const { data, isLoading, error } = useGetUserQuery()

    if (isLoading) {
        return "Loading..."
    }

    if (error) {
        return <Navigate to="/login" replace />;
    }

    return JSON.stringify(data)
}

export default Home;