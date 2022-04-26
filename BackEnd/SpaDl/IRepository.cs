namespace SpaDl;
public class IRepository
{
    /// <summary>
    ///     this will add a student to the database and assign them to the enterance exam
    ///     The enterance exam is automaticlly assigned
    /// </summary>
    /// <param name="info"></param>
    /// <returns></returns>
    Users AddUsers(Users info);
//-----------------------------------------------------------------------------------------//
    /// <summary>
    ///     this will pull user profile from the database. This will display the following:
    ///     Username,Real Name
    ///     Location
    ///     Current Rank in the VA(Virtual Airlines)
    ///     picture of thier chose
    ///     any exams needed to complete to advance
    /// </summary>
    /// <param name=""></param>
    /// <returns></returns>
    Users userProfile();
    //------------------------------------------------------------------------------------//
}
