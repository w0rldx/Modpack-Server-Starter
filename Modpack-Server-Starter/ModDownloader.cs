namespace Modpack_Server_Starter
{
    public static class ModDownloader
    {
        static string GetDownloadLink(int projektId, int fileId)
        {
            return $"https://minecraft.curseforge.com/projects/{projektId}/files/{fileId}/download";
        }
    }
}